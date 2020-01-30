using System;
using System.Linq;
using System.Reflection;
using System.Xml;
using XML_Repository.Attributes;
using XML_Repository_DLL.Attributes;

namespace XML_Repository
{
    public static class XmlExtension
    {

        public static XmlNode ToXml<TModel>(this XmlDocument xdoc, TModel model, int id)
        {
            Type type = model.GetType();

            XmlNode node = xdoc.CreateNode(XmlNodeType.Element, type.Name.ToLower(), null);

            var members = type
                .GetProperties()
                .Where(p => p.GetCustomAttribute<IgnoreAttribute>() == null)
                .ToList();

            foreach (PropertyInfo member in members)
            {
                XmlNode nodemember = xdoc.CreateElement(member.Name);
                var value = member.GetValue(model);

                var dateformat = member.GetCustomAttribute<DateFormatAttribute>();
                var idmember = member.GetCustomAttribute<IdAttribute>();
                if (dateformat != null)
                {
                    if (DateTime.TryParse(value.ToString(), out DateTime date))
                    {
                        nodemember.InnerText = date.ToString(dateformat.Value);
                    }
                }
                else if (idmember != null)
                {
                    nodemember.InnerText = id.ToString();
                }
                else
                {
                    nodemember.InnerText = value?.ToString();
                }
                node.AppendChild(nodemember);

            }
            return node;

        }

        public static bool IsIgnodred(this PropertyInfo p)
        {
            return p.GetCustomAttribute<IgnoreAttribute>() != null;
        }

        public static T ToModel<T>(this XmlNode xnode) where T : new()
        {
            Type type = typeof(T);
            if (type.Name.ToUpper() != xnode.Name.ToUpper())
            {
                throw new ArgumentException("Different model type");
            }

            var source = new T();
            var members = type
                .GetProperties()
                .Where(p => !p.IsIgnodred())
                .Where(p => p.GetCustomAttribute<AgeIgnoreAttribute>() == null)
                .ToDictionary(p => p.Name.ToUpper(), p => p);
            foreach (XmlNode xchild in xnode.ChildNodes)
            {
                if (members.TryGetValue(xchild.Name.ToUpper(), out PropertyInfo member))
                {
                    if (member.GetCustomAttribute<DateFormatAttribute>() != null)
                    {
                        if (DateTime.TryParse(xchild.InnerText, out DateTime date))
                        {
                            member.SetValue(source, date);
                        }
                    }
                    else if (member.GetCustomAttribute<IdAttribute>() != null)
                    {
                        member.SetValue(source, int.Parse(xchild.InnerText));
                    }
                    else
                    {
                        member.SetValue(source, xchild.InnerText);
                    }

                }
            }
            return source;
        }

        public static XmlNode RemoveById(this XmlNode xnode, int id)
        {
            foreach (XmlNode xchild in xnode.ChildNodes)
            {
                foreach (XmlNode childnode in xchild.ChildNodes)
                {
                    if (childnode.Name.ToLower() == "id" && childnode.InnerText.ToString() == id.ToString())
                    {
                        xnode.RemoveChild(xchild);
                        break;
                    }
                }

            }
            return xnode;
        }

        public static XmlNode RemoveXML(this XmlNode xnode)
        {
            xnode.RemoveAll();

            return xnode;
        }



        public static int GetMaxId(this XmlNode xnode)
        {
            int max = 0;
            foreach (XmlNode xchild in xnode.ChildNodes)
            {
                if (xchild.HasChildNodes)
                {
                    foreach (XmlNode childnode in xchild.ChildNodes)
                    {
                        if (childnode.Name.ToLower() == "id")
                        {
                            if (int.Parse(childnode.Value) > max)
                            {
                                max = int.Parse(childnode.Value);
                            }
                        }
                    }
                }
                else
                {
                    return 0;
                }

            }
            return max;

        }


    }
}
