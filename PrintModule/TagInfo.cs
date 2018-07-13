﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintModule
{
    public class TagInfo
    {
        public TagInfo(string Type, string Info)
        {
            this.Type = Type;
            this.Info = Info;
        }
        /// <summary>
        /// PictureBox的种类
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Image包含的信息
        /// </summary>
        public string Info { get; set; }
    }
}
