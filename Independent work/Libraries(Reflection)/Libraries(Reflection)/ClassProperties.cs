using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Libraries_Reflection_
{
    static class ClassProperties
    {
        private static string GetInfo(MethodInfo method)
        {
            string result = "";

            if (method.IsPrivate)
            {
                result += "private ";
            }
            else if (method.IsPublic)
            {
                result += "public ";
            }
            else { }

            if (method.IsStatic)
            {
                result += "static ";
            }
            else if (method.IsVirtual)
            {
                result += "virtual ";
            }
            else { }

            result += String.Format("{0} {1}", method.ReturnType, method.Name);

            ParameterInfo[] parameters = method.GetParameters();

            result += "(";
            for (int i = 0; i < parameters.Length; ++i)
            {
                if (i < parameters.Length - 1)
                {
                    result += String.Format("{0}, ", parameters[i]);
                }
                else
                {
                    result += String.Format("{0}", parameters[i]);
                }
            }
            result += ")";

            return result;
        }
        public static void ColorPrint(object obj)
        {
            try
            {
                Type objType = obj.GetType();
                Console.WriteLine("Investigation class {0}", objType);

                PropertyInfo[] notPublicProperties = objType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                PropertyInfo[] publicProperties = objType.GetProperties();
                PropertyInfo[] allProperties = new PropertyInfo[notPublicProperties.Length + publicProperties.Length];

                notPublicProperties.CopyTo(allProperties, 0);
                publicProperties.CopyTo(allProperties, notPublicProperties.Length - 1);

                foreach (PropertyInfo item in allProperties)
                {
                    ConsoleColor currentColor;
                    object[] attributes = item.GetCustomAttributes(typeof(PropertyColorAttribute), false);

                    if (attributes.Length > 0)
                    {
                        currentColor = ((PropertyColorAttribute)attributes[0]).propColor;
                    }
                    else
                    {
                        currentColor = ConsoleColor.Gray;
                    }
                    Console.ForegroundColor = currentColor;
                    Console.WriteLine("\t-" + GetInfo(item.SetMethod));
                    Console.WriteLine("\t-" + GetInfo(item.GetMethod));
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
