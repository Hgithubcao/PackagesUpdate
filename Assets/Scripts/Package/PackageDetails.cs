﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = UnityEngine.Object;

public class PackageDetails : Property
{
	public PackageDetails(Type belongType, string name) : base(belongType, name)
	{
	}

	public void SetWindow(Object window)
	{
		SetBelong(window);
	}
}
