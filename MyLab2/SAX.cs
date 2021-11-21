using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyLab2
{
    class SAX : IStrategy
    {
        public List<Scientific_works> AnalyseFile(Scientific_works sci_works, string path)
        {
            List<Scientific_works> result = new List<Scientific_works>();
            
            var xmlReader = new XmlTextReader(path);

            while (xmlReader.Read())
            {

                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
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

                        if (xmlReader.Name.Equals("FullName") &&
                            (xmlReader.Value.Equals(sci_works.FullName) || sci_works.FullName.Equals(String.Empty)))
                        {
                            FullName = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Faculty") &&
                            (xmlReader.Value.Equals(sci_works.Faculty) || sci_works.Faculty.Equals(String.Empty)))
                        {
                            Faculty = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Department") && (xmlReader.Value.Equals(sci_works.Department) ||
                                                                    sci_works.Department.Equals(String.Empty)))
                        {
                            Department = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Position") &&
                            (xmlReader.Value.Equals(sci_works.Position) || sci_works.Position.Equals(String.Empty)))
                        {
                            Position = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Scientific_Work") &&
                            (xmlReader.Value.Equals(sci_works.Scientific_Work) ||
                             sci_works.Scientific_Work.Equals(String.Empty)))
                        {
                            Scientific_Work = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Customer") &&
                            (xmlReader.Value.Equals(sci_works.Customer) || sci_works.Customer.Equals(String.Empty)))
                        {
                            Customer = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Address") &&
                            (xmlReader.Value.Equals(sci_works.Address) || sci_works.Address.Equals(String.Empty)))
                        {
                            Address = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Subordination") &&
                            (xmlReader.Value.Equals(sci_works.Subordination) ||
                             sci_works.Subordination.Equals(String.Empty)))
                        {
                            Subordination = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (xmlReader.Name.Equals("Area") &&
                            (xmlReader.Value.Equals(sci_works.Area) || sci_works.Area.Equals(String.Empty)))
                        {
                            Area = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                        }

                        if (FullName != "" && Faculty != "" && Department != "" && Position != "" &&
                            Scientific_Work != "" &&
                            Customer != "" && Address != "" && Subordination != "" && Area != "")
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
                }
            }
            xmlReader.Close();
            return result;
        }
    }
}

