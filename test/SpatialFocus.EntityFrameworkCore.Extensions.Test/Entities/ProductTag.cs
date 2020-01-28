﻿// <copyright file="ProductTag.cs" company="Spatial Focus">
// Copyright (c) Spatial Focus. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace SpatialFocus.EntityFrameworkCore.Extensions.Test.Entities
{
	public class ProductTag
	{
		public int ProductTagId { get; set; }

		public virtual Product Product { get; set; }

		public string Name { get; set; }
	}
}