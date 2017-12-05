﻿using System;
using System.Collections.Generic;
using Conditions;

namespace ProjectManagement.Domain
{
    /// <inheritdoc />
    /// <summary>
    ///     Represents a Donor which is in charge of disbursing money for one or more projects
    /// </summary>
    public sealed class Donor : IEntity
    {
        /// <summary>
        ///     For OR/M usage
        /// </summary>
        private Donor()
        {
        }

        /// <summary>
        ///     Private constructor used to initialize a new instance of the Entity
        /// </summary>
        public Donor(string name)
        {
            // pre-conditions
            name.Requires().IsNotNullOrEmpty();

            // initialization
            Id = Guid.NewGuid();
            Projects = new List<ProjectAggregate>();
            Name = name;
        }

        /// <summary>
        ///     The Unique Name of the Donor
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The List of Projects funded by a Donor
        /// </summary>
        public IList<ProjectAggregate> Projects { get; set; }

        /// <inheritdoc />
        /// <summary>
        ///     The Unique Id of the Donor
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        ///     Assign a Project to the related Donor
        /// </summary>
        /// <param name="project">The Project to be assigned</param>
        internal void AssignProjectToDonor(ProjectAggregate project)
        {
            Projects.Add(project);
        }
    }
}