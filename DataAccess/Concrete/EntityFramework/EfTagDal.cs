﻿using Core.EntityFramework;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTagDal : EfEntityRepository<Tags, TaskContext>
    {
    }
}
