﻿namespace ProjectManagement.Dal.Nhb
{
    /// <summary>
    /// Implementation of a Generic transaction contract using NHibernate
    /// </summary>
    public sealed class Transaction : ITransaction
    {
        /// <summary>
        /// The unerlying NHibernate transaction
        /// </summary>
        private readonly NHibernate.ITransaction transaction;

        /// <summary>
        /// Create a new Generic Transaction by using an underlying NHibernate transaction
        /// </summary>
        /// <param name="transaction">Return an instance of an ITransaction contract</param>
        public Transaction(NHibernate.ITransaction transaction)
        {
            this.transaction = transaction;
        }

        /// <summary>
        /// Dispose the current transaction
        /// </summary>
        public void Dispose()
        {
            transaction.Dispose();
        }

        /// <summary>
        /// Commit the current transaction
        /// </summary>
        public void Commit()
        {
            transaction.Commit();
        }

        /// <summary>
        /// Rollback the current transaction
        /// </summary>
        public void Rollback()
        {
            transaction.Rollback();
        }
    }
}