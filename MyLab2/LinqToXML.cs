using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MyLab2
{
    class LinqToXML : IStrategy
    {
        List<Scientific_works> result = new List<Scientific_works>();
        XDocument doc = new XDocument();
        public LinqToXML(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Scientific_works> AnalyseFile(Scientific_works sci_works, string path)
        {
            var res = from mySearch in doc.Descendants("ScientificWork")
                where (mySearch.Attribute("FullName").Value.Equals(sci_works.FullName) ||
                       sci_works.FullName.Equals(String.Empty)) &&
                      (mySearch.Attribute("Faculty").Value.Equals(sci_works.Faculty) ||
                       sci_works.Faculty.Equals(String.Empty)) &&
                      (mySearch.Attribute("Department").Value.Equals(sci_works.Department) ||
                       sci_works.Department.Equals(String.Empty)) &&
                      (mySearch.Attribute("Position").Value.Equals(sci_works.Position) ||
                       sci_works.Position.Equals(String.Empty)) &&
                      (mySearch.Attribute("Scientific_Work").Value.Equals(sci_works.Scientific_Work) ||
                       sci_works.Scientific_Work.Equals(String.Empty)) &&
                      (mySearch.Attribute("Customer").Value.Equals(sci_works.Customer) ||
                       sci_works.Customer.Equals(String.Empty)) &&
                      (mySearch.Attribute("Address").Value.Equals(sci_works.Address) ||
                       sci_works.Address.Equals(String.Empty)) &&
                      (mySearch.Attribute("Subordination").Value.Equals(sci_works.Subordination) ||
                       sci_works.Subordination.Equals(String.Empty)) &&
                      (mySearch.Attribute("Area").Value.Equals(sci_works.Area) || sci_works.Area.Equals(String.Empty))
                select new
                {
                    fullname = (string)mySearch.Attribute("FullName"),
                    faculty = (string)mySearch.Attribute("Faculty"),
                    department = (string)mySearch.Attribute("Department"),
                    position = (string)mySearch.Attribute("Position"),
                    scientific_work = (string)mySearch.Attribute("Scientific_Work"),
                    customer = (string)mySearch.Attribute("Customer"),
                    address = (string)mySearch.Attribute("Address"),
                    subordination = (string)mySearch.Attribute("Subordination"),
                    area = (string)mySearch.Attribute("Area")
                };
            foreach (var match in res)
            {
                Scientific_works sci_works1 = new Scientific_works();
                sci_works1.FullName = match.fullname;
                sci_works1.Faculty = match.faculty;
                sci_works1.Department = match.department;
                sci_works1.Position = match.position;
                sci_works1.Scientific_Work = match.scientific_work;
                sci_works1.Customer = match.customer;
                sci_works1.Address = match.address;
                sci_works1.Subordination = match.subordination;
                sci_works1.Area = match.area;
                result.Add(sci_works1);
            }

            return result;
        }
    }
}
