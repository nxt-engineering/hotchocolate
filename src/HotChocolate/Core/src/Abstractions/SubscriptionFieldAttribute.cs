using System;

namespace HotChocolate;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class SubscriptionFieldAttribute : Attribute;