﻿namespace RustRetail.SharedKernel.Domain.Events
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTime OccurredOn { get; }
    }
}
