﻿using Newtonsoft.Json;

namespace Domain.Commons;

public class ActionResponse<T> : ActionResponse
{
    public ActionResponse()
    {
        Errors = new List<string>();
    }

    public T Data { get; set; }

}
public class ActionResponse : IActionResponse
{
    public ActionResponse()
    {
        Errors = new List<string>();
    }
    public int Status { get; set; }
    public string Message { get; set; }
    public ResponseStateEnum State { get; set; }
    public List<string> Errors { get; set; }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}

public interface IActionResponse
{
    int Status { get; set; }
    string Message { get; set; }
    ResponseStateEnum State { get; set; }
    List<string> Errors { get; set; }
}

public enum ResponseStateEnum
{
    NOTFOUND = -1,
    FAILED = 0,
    SUCCESS = 1,
    NOTAUTHORIZED = 2
}