using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.String;

namespace MyLab2
{
    class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);
        }
        public List<Scientific_works> AnalyseFile(Scientific_works sci_works, string path)
        {
            List<Scientific_works> result = new List<Scientific_works>();

            XmlElement node = doc.DocumentElement;

            foreach (XmlNode nod in node.ChildNodes)
            {   
                string FullName = "";
                string Faculty = "";
                string Department = "";
                string Position = "";
                string Scientific_Work = "";
                string Customer = "";
                string Address = "";
                string Subordination = "";
                string Area = "";

                foreach (XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name.Equals("FullName") &&
                        (attribute.Value.Equals(sci_works.FullName) || sci_works.FullName.Equals(String.Empty)))
                    {
                        FullName = attribute.Value;
                    }

                    if (attribute.Name.Equals("Faculty") &&
                        (attribute.Value.Equals(sci_works.Faculty) || sci_works.Faculty.Equals(String.Empty)))
                    {
                        Faculty = attribute.Value;
                    }

                    if (attribute.Name.Equals("Department") && (attribute.Value.Equals(sci_works.Department) ||
                                                                sci_works.Department.Equals(String.Empty)))
                    {
                        Department = attribute.Value;
                    }

                    if (attribute.Name.Equals("Position") && (attribute.Value.Equals(sci_works.Position) ||
                                                                sci_works.Position.Equals(String.Empty)))
                    {
                        Position = attribute.Value;
                    }

                    if (attribute.Name.Equals("Scientific_Work") &&
                        (attribute.Value.Equals(sci_works.Scientific_Work) || sci_works.Scientific_Work.Equals(String.Empty)))
                    {
                        Scientific_Work = attribute.Value;
                    }

                    if (attribute.Name.Equals("Customer") &&
                        (attribute.Value.Equals(sci_works.Customer) || sci_works.Customer.Equals(String.Empty)))
                    {
                        Customer = attribute.Value;
                    }

                    if (attribute.Name.Equals("Address") &&
                        (attribute.Value.Equals(sci_works.Address) || sci_works.Address.Equals(String.Empty)))
                    {
                        Address = attribute.Value;
                    }

                    if (attribute.Name.Equals("Subordination") && (attribute.Value.Equals(sci_works.Subordination) ||
                                                                   sci_works.Subordination.Equals(String.Empty)))
                    {
                        Subordination = attribute.Value;
                    }

                    if (attribute.Name.Equals("Area") &&
                        (attribute.Value.Equals(sci_works.Area) || sci_works.Area.Equals(String.Empty)))
                    {
                        Area = attribute.Value;
                    }
                }

                if (FullName != "" && Faculty != "" && Department != "" && Position != "" && Scientific_Work != "" && Customer != "" && Address != "" && Subordination != "" && Area != "")
                {
                    Scientific_works sci_works1 = new Scientific_works();

                    sci_works1.FullName = FullName;
                    sci_works1.Faculty = Faculty;
                    sci_works1.Department = Department;
                    sci_works1.Position = Position;
                    sci_works1.Scientific_Work = Scientific_Work;
                    sci_works1.Customer = Customer;
                    sci_works1.Address = Address;
                    sci_works1.Subordination = Subordination;
                    sci_works1.Area = Area;

                    result.Add(sci_works1);
                }
            }
            return result;
        }
    }
}
