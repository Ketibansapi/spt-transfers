﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsTransfer.Models;

namespace SportsTransfer.ViewModels
{
    public class RandomTransferViewModel
    {
       public Transfer Transfer { get; set; }
       public List<Customer> Customers { get; set; }
    }
}