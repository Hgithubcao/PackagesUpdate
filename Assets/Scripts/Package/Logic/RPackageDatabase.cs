﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPackageDatabase : Class
{
	Property s_instance;
	PackageDatabaseInternal instanceInternal;



	public RPackageDatabase(Type type) : base(type)
	{
		s_instance = new Property(this, "instance");

		var value = s_instance.GetValue();
		SetInstance(value);


		instanceInternal = new PackageDatabaseInternal(value.GetType());
		instanceInternal.SetInstance(value);
	}

	public class PackageDatabaseInternal : Class
	{
		Property allPackages;

		public PackageDatabaseInternal(Type type) : base(type)
		{
			allPackages = new Property(this, "allPackages");
		}

		protected override void OnSetInstance()
		{
			//ShowMembersValue();
			var value = allPackages.Value as ICollection;
			Debug.Log(value.Count);

		}
	}
}
