using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjetoEstacionamento.Uteis
{
    public static class ReflexaoUtil
    {
        public static List<Type> TypesCustomAttributes(this object objeto)
        {
            return Assembly.
                            GetExecutingAssembly()
                            .GetTypes()
                            .Where(x => x.GetType().IsClass && x.GetCustomAttributes(false) != null)
                            .ToList();
        }
        /// <summary>
        /// Retorna todos tipos de atributos customizados do tipo TAtribute do objeto indicado
        /// em uma List.
        /// </summary>
        /// <typeparam name="TAttribute">Tipo dos Atributos Customizado</typeparam>
        /// <param name="objeto">Objeto</param>
        /// <returns></returns>
        public static List<Type> Types<TAttribute>(this object objeto) where TAttribute : class
        {
            var tipos = objeto.TypesCustomAttributes();

            return (List<Type>)tipos.Where(x => x.GetCustomAttributes(false)
                .Any(y => (y as TAttribute) != null));
            //.GetCustomAttributes(false).Where(x => x is TAttribute).First();
        }

        public static TAttribute Attribute<TAttribute>(this Type objeto) where TAttribute : class
        {
            return (TAttribute)objeto.GetCustomAttributes(false).Where(x => x is TAttribute).First();
        }
    }
}
