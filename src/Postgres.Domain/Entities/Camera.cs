﻿using System;

namespace Postgres.Domain.Entities
{
    public class Camera
    {
        public Guid CameraId { get; set; }
        public string CameraName { get; set; }
        public string CameraGroup { get; set; }
        public bool Active { get; set; }
        public byte[] DisplayImage { get; set; }
        public decimal MinimumHeadSize { get; set; }
        public decimal MaximumHeadSize { get; set; }
        public decimal Threshold { get; set; }
    }
}