﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSlaLogDtos
{
    public class CreateTaskSlaLogDto
    {
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
    }
}
