﻿using System;
using System.Collections.Generic;
using System.Linq;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Shared.Data
{
    /// <summary>
    /// Repository for activities.
    /// </summary>
    public class ActivitiesRepository : BaseRepository<Activity>
    {
        public ActivitiesRepository(Context context) 
            : base(context)
        {
        }

        public  Activity Get(int id, bool includeRelatedEntities = true)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a collection of activities.
        /// </summary>
        /// <returns>A list of activities.</returns>
        public  IList<Activity> GetList()
        {
            return Context.Activities
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}