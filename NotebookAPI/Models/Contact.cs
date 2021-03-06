﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NotebookAPI.Models
{
    public class Contact : BaseEntity
    {
        public string Value { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }

        public int? ContactTypeId { get; set; }
        public virtual ContactType ContactType { get; set; }

    }
}
