﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string investigatedClass)
    {
        StringBuilder stringBuilder = new StringBuilder();
        Type classType = Type.GetType(investigatedClass);

        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");

        }

        return stringBuilder.ToString().Trim();
    }
}