using Bayards_Safety_App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bayards_Safety_App.DTO
{
    public class ShellRequest<T>
    {
        /// <summary>
        /// Data list -- is a list of specified type, SafetyObject/SectionRisk/etc
        /// </summary>
        public List<T> Data { get; set; }
    }
}
