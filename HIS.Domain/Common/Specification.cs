using HIS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Domain.Common
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; protected set; }
            = default!;

        public virtual Expression<Func<T, object>>[] Includes
            => [];

        public bool IsSatisfiedBy(T entity)
        {
            return Criteria.Compile()(entity);
        }
    }
}
