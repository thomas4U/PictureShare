﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Wenn der Code neu generiert wird, gehen alle Änderungen an dieser Datei verloren
// </auto-generated>
//------------------------------------------------------------------------------
namespace Core.Data.Structure
{
	using Core.Data;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public abstract class BaseDeviceRepository : IDeviceRepository
	{
		protected IEnumerable<DeviceEntity> Devices;

		public virtual DeviceEntity GetDevice(int id)
		{
			throw new System.NotImplementedException();
		}

		public abstract void AddDevice(DeviceEntity device);

		public abstract void DeleteDevice(DeviceEntity device);

		public abstract IEnumerable<DeviceEntity> GetAll();

		public virtual DeviceEntity GetDevice(string deviceId)
		{
			throw new System.NotImplementedException();
		}

		public virtual string GetImagePath(int id)
		{
			throw new System.NotImplementedException();
		}

		public virtual DeviceEntity GetImagePath(string deviceId)
		{
			throw new System.NotImplementedException();
		}

		public virtual void UpdateDevice(DeviceEntity device)
		{
			throw new System.NotImplementedException();
		}

	}
}

