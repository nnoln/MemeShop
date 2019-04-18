﻿using BLL.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDiscountCodeService
    {
        IEnumerable<DTODiscountCode> GetAllCodes();
        void Create(DTODiscountCode context);
        void Delete(int id);
    }
}
