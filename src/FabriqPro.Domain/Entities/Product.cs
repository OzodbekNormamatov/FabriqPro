﻿using FabriqPro.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Domain.Entities;

public class Product:Auditable
{
    public string Code {  get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public decimal IrnonerPrice { get; set;}
    public decimal CleanerPrice {  get; set;}
    public decimal PackagingPrice { get; set;}
}
