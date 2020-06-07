﻿using System;
using System.Xml;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace HandlingEditor.Client
{
    // TODO: When a preset is created/copied
    //       Add options to handle all the cases:
    //       1.Only update common fields
    //       2.Update everything
    //       3.Deep copy
    //       How are the default values handled?

    //       Same for saving, what should be saved?
    //       1.Everything
    //       2.Only edited fields
    //       Also remember to check permissions


    //public static class HandlingPresetExtensions
    //{
    //    public static string ToXml(this HandlingData preset, string presetName = null)
    //    {
    //        XmlDocument doc = new XmlDocument();
    //        XmlElement handlingItem = doc.CreateElement("Item");
    //        handlingItem.SetAttribute("type", "CHandlingData");

    //        if(!string.IsNullOrEmpty(presetName))
    //            handlingItem.SetAttribute("presetName", presetName);

    //        foreach (var item in preset.Fields)
    //        {
    //            string fieldName = item.Key;
    //            dynamic fieldValue = item.Value;
    //            XmlElement field = doc.CreateElement(fieldName);

    //            if (!Framework.HandlingInfo.Fields.TryGetValue(fieldName, out HandlingFieldInfo fieldInfo))
    //            {
    //                // TODO:
    //                continue;
    //            }

    //            Type fieldType = fieldInfo.Type;

    //            if (fieldType == HandlingFieldTypes.FloatType)
    //            {
    //                var value = (float)fieldValue;
    //                field.SetAttribute("value", value.ToString());
    //            }
    //            else if (fieldType == HandlingFieldTypes.IntType)
    //            {
    //                var value = (int)fieldValue;
    //                field.SetAttribute("value", value.ToString());
    //            }
    //            else if (fieldType == HandlingFieldTypes.Vector3Type)
    //            {
    //                var value = (Vector3)(fieldValue);
    //                field.SetAttribute("x", value.X.ToString());
    //                field.SetAttribute("y", value.Y.ToString());
    //                field.SetAttribute("z", value.Z.ToString());
    //            }
    //            else if (fieldType == HandlingFieldTypes.StringType)
    //            {
    //                field.InnerText = fieldValue;
    //            }
    //            else
    //            {

    //            }
    //            handlingItem.AppendChild(field);
    //        }
    //        doc.AppendChild(handlingItem);

    //        return doc.OuterXml;
    //    }

    //    public static void FromXml(this HandlingData preset, string xml)
    //    {
    //        XmlDocument doc = new XmlDocument();
    //        doc.LoadXml(xml);
    //        var node = doc["Item"];

    //        // Iterate Xml nodes
    //        foreach (XmlNode item in node.ChildNodes)
    //        {
    //            if (item.NodeType != XmlNodeType.Element)
    //                continue;

    //            // Get the field name
    //            string fieldName = item.Name;

    //            // Get the field type
    //            Type fieldType = HandlingFieldTypes.GetHandlingFieldTypeByName(fieldName);

    //            // Get the item as element to access attributes
    //            XmlElement elem = (XmlElement)item;

    //            // If it's a float field
    //            if (fieldType == HandlingFieldTypes.FloatType)
    //            {
    //                if (!float.TryParse(elem.GetAttribute("value"), out float result))
    //                {
    //                    // CitizenFX.Core.Debug.WriteLine($"{ScriptName}: Error parsing attribute value in {fieldName} as float.");
    //                }

    //                preset.Fields[fieldName] = result;
    //            }
    //            // If it's a int field
    //            /*
    //            else if (fieldType == FieldType.IntType)
    //            {
    //                if (!int.TryParse(elem.GetAttribute("value"), out int result))
    //                    CitizenFX.Core.Debug.WriteLine($"{ScriptName}: Error parsing attribute value in {fieldName} from preset.");

    //                preset.Fields[fieldName] = result;
    //            }*/
    //            // If it's a Vector3 field
    //            else if (fieldType == HandlingFieldTypes.Vector3Type)
    //            {
    //                if (!float.TryParse(elem.GetAttribute("x"), out float x))
    //                {
    //                    // CitizenFX.Core.Debug.WriteLine($"{ScriptName}: Error parsing attribute x in {fieldName} from preset.");
    //                }
    //                if (!float.TryParse(elem.GetAttribute("y"), out float y))
    //                {
    //                    // CitizenFX.Core.Debug.WriteLine($"{ScriptName}: Error parsing attribute y in {fieldName} from preset.");
    //                }
    //                if (!float.TryParse(elem.GetAttribute("z"), out float z))
    //                {
    //                    // CitizenFX.Core.Debug.WriteLine($"{ScriptName}: Error parsing attribute z in {fieldName} from preset.");
    //                }
    //                preset.Fields[fieldName] = new Vector3(x, y, z);
    //            }/*
    //            else if (fieldType == FieldType.StringType)
    //            {
    //                preset.Fields[fieldName] = elem.InnerText;
    //            }*/
    //            else
    //            {
    //                // Unexpected
    //            }
    //        }
    //    }
}
