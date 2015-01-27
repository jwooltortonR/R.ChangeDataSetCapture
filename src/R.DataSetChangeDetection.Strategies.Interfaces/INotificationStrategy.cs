﻿using System.Data;

namespace R.DataSetChangeDetection.Strategies.Interfaces
{
    public interface INotificationStrategy
    {
        void Insert(DataRow dataRow);
        void Amend(DataRow dataRow);
        void Cancel(DataRow dataRow);
        void NoChange(DataRow dataRow);
    }
}