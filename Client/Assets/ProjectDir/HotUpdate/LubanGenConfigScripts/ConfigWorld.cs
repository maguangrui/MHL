//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg
{ 

public sealed partial class ConfigWorld :  Bright.Config.BeanBase 
{
    public ConfigWorld(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["content"].IsString) { throw new SerializationException(); }  Content = _json["content"]; }
        PostInit();
    }

    public ConfigWorld(int id, string name, string content ) 
    {
        this.Id = id;
        this.Name = name;
        this.Content = content;
        PostInit();
    }

    public static ConfigWorld DeserializeConfigWorld(JSONNode _json)
    {
        return new ConfigWorld(_json);
    }

    /// <summary>
    /// id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; private set; }

    public const int __ID__ = 1677855056;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Content:" + Content + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}