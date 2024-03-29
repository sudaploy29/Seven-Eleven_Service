﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevenEleven.DTOs
{
      public class PaginationDto
      {
            public int Page { get; set; } = 1;
            private int recordsPerPage = 10;
            private readonly int maxRecordsPerPage = 50;

            public int RecordsPerPage
            {
                  get
                  {
                        return recordsPerPage;
                  }
                  set
                  {
                        recordsPerPage = (value > maxRecordsPerPage) ? maxRecordsPerPage : value;
                  }
            }

            public string OrderingField { get; set; }

            public bool AscendingOrder { get; set; } = true;
      }
}