using ShapeAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLibrary
{
    public static class ShapeManager
    {
        private static Dictionary<string, Type> shapeTypes = new Dictionary<string, Type>();

        public static void RegisterShapeType(string shapeName, Type type)
        {
            if (!typeof(IShape).IsAssignableFrom(type))
                throw new ArgumentException("Тип должен реализовывать IShape интерфейс", nameof(type));

            shapeTypes[shapeName] = type;
        }

        public static void RegisterShapeType(string shapeName, string assemblyPath, string typeName)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType(typeName);

            if (type == null || !typeof(IShape).IsAssignableFrom(type))
                throw new ArgumentException("Тип должен существовать и реализовывать IShape интерфейс", nameof(typeName));

            shapeTypes[shapeName] = type;
        }

        public static IShape CreateShape(string shapeName, params object[] args)
        {
            if (!shapeTypes.ContainsKey(shapeName))
                throw new ArgumentException($"Фигура '{shapeName}' не распознана", nameof(shapeName));

            Type? type = shapeTypes[shapeName];
            return Activator.CreateInstance(type, args) as IShape;
        }
    }
}
