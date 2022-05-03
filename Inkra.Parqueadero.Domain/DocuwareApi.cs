using Inkra.Parqueadero.Domain.Generico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inkra.Parqueadero.Domain
{
    public class DocuwareApi<T> where T : class , new()
    {
        public TResult CONSULTAR_DOCUWARE<TResult>(string archivador, string tipobusqueda, string valorbusqueda)
        {
            return (TResult)Convert.ChangeType(new ModelListado(), typeof(TResult)); ;
        }

        public T CONSULTAR_DOCUWARE(string archivador, string tipobusqueda, string valorbusqueda)
        {
            Type d1 = typeof(T);
            object o = Activator.CreateInstance(d1);

            T o2 = new();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            foreach (PropertyDescriptor p in properties)
            {

                if (p.PropertyType == typeof(bool) || p.PropertyType == typeof(bool?))
                {
                //    if (propertyValue != null && propertyValue == "on")
                //    {
                //        propertyValue = "true";
                //    }
                //    else
                //    {
                //        propertyValue = "false";
                //    }
                }

                //if ((Propiedad.PropertyType.IsGenericType))
                //{
                //    var Agregar = Propiedad.PropertyType.GetMethod("Add");
                //    if (Agregar != null)
                //    {
                //        Agregar.Invoke(Propiedad.GetValue(UOW, null), new[] { objeto });
                //    }

                //}

                //// 1. Obtener el método "Add"
                //Agregar = Propiedad.PropertyType.GetMethod("Add");
                //// 2. Obtener el valor de la propiedad lista
                //var lista = Propiedad.GetValue(UnidadDeTrabajo, null);
                //// 3. Llamar al método Add de lista
                //Agregar.Invoke(lista, new[] { objeto });

                if (p.Name == "Archivador")
                    p.SetValue(o2, p.Converter.ConvertFrom(archivador));

                if (p.Name == "TipoBusqueda")
                    p.SetValue(o2, p.Converter.ConvertFrom(tipobusqueda));

                if (p.Name == "ValorBusqueda")
                    p.SetValue(o2, p.Converter.ConvertFrom(valorbusqueda));


                if (p.Name == "ListaDocumentos") {

                    Type listaTpye = p.PropertyType;

                    TypeInfo t = listaTpye.GetTypeInfo();
                    IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
                    //IEnumerable<MethodInfo> mList = t.DeclaredMethods;

                    foreach (var item in pList)
                    {
                        if (item.Name == "Item")
                        {
                            Type empTipye = item.PropertyType;
                            object r1 = Activator.CreateInstance(empTipye);
                            object r4 = new();

                         

                            MethodInfo methodInfo = p.PropertyType.GetMethod("Add");
                            ParameterInfo[] parameterInfo = methodInfo.GetParameters();
                            object classInstance = Activator.CreateInstance(listaTpye, null);

                            if (parameterInfo.Length == 0)
                            {
                                // there is no parameter we can call with 'null'
                                var result = methodInfo.Invoke(classInstance, null);
                            }
                            else
                            {
                                var result = methodInfo.Invoke(classInstance, new object[] { r1 });
                                methodInfo.Invoke(classInstance, new object[] { r1 });
                                methodInfo.Invoke(classInstance, new object[] { r1 });
                                methodInfo.Invoke(classInstance, new object[] { r1 });
                            }

                            //Agregar.Invoke(p, new Object[] { r1 });
                            p.SetValue(o2, classInstance);
                        }
                    }
                }

            }

            return (T)Convert.ChangeType(o2, typeof(T)); ;
        }
    }
}