using System;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>>? Criteria { get; }
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDescending { get; }
        bool IsDistinct { get; }
        int Take {get;}
        int Skip {get;}
        bool IsPagingEnabled { get; }
        IQueryable<T> ApplyCriteria(IQueryable<T> query);
    }
}

public interface ISpecification<T, TResult> : ISpecification<T>
{
    Expression<Func<T, TResult>>? Selector { get; }
}