﻿namespace Postgres.Domain.Entities
{
    public class Setting
    {
        public int SettingId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}