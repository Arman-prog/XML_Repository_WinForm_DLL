using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_Repository.Models;

namespace XML_Repository
{
    public abstract class BaseRepository<TModel> where TModel : new()
    {
        public string FileName { get; }
        public int Id { get; set; }

        public BaseRepository(string filename)
        {
            FileName = filename;
        }

        public IEnumerable<TModel> AsEnumerable()
        {
            var XDoc = new XmlDocument();
            XDoc.Load(FileName);
            var xRoot = XDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot.ChildNodes)
            {
                yield return xnode.ToModel<TModel>();
            }
        }

        public void Add(TModel model)
        {
            var xdoc = new XmlDocument();
            xdoc.Load(FileName);

            if (Id == 0)
            {
                Id = xdoc.GetMaxId();
            }

            XmlNode xnode = xdoc.ToXml(model, Id);
            xdoc.DocumentElement.AppendChild(xnode);
            xdoc.Save(FileName);
        }

        public void AddRange(IEnumerable<TModel> models)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(FileName);

            Id = xdoc.GetMaxId();

            foreach (var model in models)
            {
                XmlNode xnode = xdoc.ToXml(model, Id);
                xdoc.DocumentElement.AppendChild(xnode);
                Id++;
            }
            xdoc.Save(FileName);
        }

        public void RemoveAT(int id)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(FileName);
            var xroot = xdoc.DocumentElement;
            XmlNode xnode = xroot.RemoveById(id);
            xdoc.Save(FileName);
        }

        public void RemoveAll()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(FileName);
            var xroot = xdoc.DocumentElement;
            XmlNode xnode = xroot.RemoveXML();
            xdoc.Save(FileName);
        }



    }
}
