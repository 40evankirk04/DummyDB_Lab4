﻿namespace DummyDB
{
    public class Row
    {
        public Dictionary<SchemeColumn, object> Data { get; set; }
        public Row()
        {
            Data = new Dictionary<SchemeColumn, object>();
        }
    }
}
