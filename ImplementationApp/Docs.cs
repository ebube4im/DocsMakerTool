using DocsMakerTool.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationApp
{
    public class Docs
    {

        public void GetDocs()
        {
            Assembly asm = Assembly.GetCallingAssembly();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            Console.WriteLine(asm.FullName);

            using (StreamWriter sw = new StreamWriter("Docs.txt"))
            {



                foreach (var assembly in assemblies)
                {
                     Console.WriteLine($"{ assembly} Documentation");
                    sw.WriteLine(assembly.FullName);
                    var types = assembly.GetTypes();
                    foreach (var type in types)
                    {

                        //  Console.WriteLine(type);

                        var constructors = type.GetConstructors();
                        if (constructors.Length > 0)
                        {
                            foreach (var item in constructors)
                            {
                                var customAttributes = item.GetCustomAttributes(typeof(DocumentAttribute), false);
                                if (customAttributes.Any())
                                {
                                    Console.WriteLine(" \t Constructor(s): ");
                                    Console.WriteLine($"\t \t {item.Name}");
                                    Console.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    Console.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    Console.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");

                                    sw.WriteLine(" \t Constructor(s): ");
                                    sw.WriteLine($"\t \t {item.Name}");
                                    sw.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    sw.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    sw.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");
                                }
                            }


                        }

                        var properties = type.GetProperties();
                        if (properties.Length > 0)
                        {
                            foreach (var item in properties)
                            {
                                var customAttributes = item.GetCustomAttributes(typeof(DocumentAttribute), false);
                                if (customAttributes.Any())
                                {
                                    Console.WriteLine(" \t Property(s): ");
                                    Console.WriteLine($"\t \t {item.Name}");
                                    Console.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    Console.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    Console.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");

                                    sw.WriteLine(" \t Property(s): ");
                                    sw.WriteLine($"\t \t {item.Name}");
                                    sw.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    sw.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    sw.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");
                                }
                            }


                        }



                        var methods = type.GetMethods();
                        if (methods.Length > 0)
                        {
                            foreach (var item in methods)
                            {
                                var customAttributes = item.GetCustomAttributes(typeof(DocumentAttribute), false);
                                if (customAttributes.Any())
                                {
                                    Console.WriteLine(" \t Methods(s): ");
                                    Console.WriteLine($"\t \t {item.Name}");
                                    Console.WriteLine($"\t \t {item.ReturnParameter}");
                                    Console.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    Console.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    Console.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");

                                    sw.WriteLine(" \t Methods(s): ");
                                    sw.WriteLine($"\t \t {item.Name}");
                                    sw.WriteLine($"\t \t {item.ReturnParameter}");
                                    sw.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                                    sw.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                                    sw.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");
                                }
                            }


                        }

                        //var enums = type.GetEnumNames();
                        //if (enums.Length > 0)
                        //{
                        //    foreach (var item in enums)
                        //    {

                        //        //var customAttributes = item
                        //        //    item.GetCustomAttributes(typeof(DocumentAttribute), false);
                        //        //if (customAttributes.Any())
                        //        //{
                        //            Console.WriteLine(" \t Methods(s): ");
                        //        Console.WriteLine($"\t \t {item}");
                        //            //Console.WriteLine($"\t \t {item.ReturnParameter}");
                        //            //Console.WriteLine($"\t \t Description: \n \t \t \t{((DocumentAttribute)customAttributes[0]).Description}");
                        //            //Console.WriteLine($"\t \t Input: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Input}");
                        //            //Console.WriteLine($"\t \t Output: \n \t \t \t {((DocumentAttribute)customAttributes[0]).Output}");
                        //       // }
                        //    }


                        //}




                        int classcount = 1;
                        //foreach (var member in members)
                        //{

                        //    var attributes = member.GetCustomAttributes(typeof(DocumentAttribute), false);
                        //    if (attributes.Length > 0)
                        //    {

                        //        Console.WriteLine("Classes: ");
                        //        Console.WriteLine($" {classcount} {member.ReflectedType.Name}");
                        //        Console.WriteLine("Name: {0}", member.);
                        //        Console.WriteLine($"Description: {((DocumentAttribute)attributes[0]).Description}");
                        //        Console.WriteLine($"Input: {((DocumentAttribute)attributes[0]).Input}");
                        //        Console.WriteLine($"Output: {((DocumentAttribute)attributes[0]).Output}");
                        //        Console.WriteLine();
                        //    }
                        classcount++;
                        //}
                    }
                }

            }
        }

        public void GetDocsToTxt()
        {

        }

        public void GetDocsToJSON()
        {

        }

        public void GetDocsToXML()
        {

        }

        public void GetDocsToPDF()
        {

        }
    }
}
