namespace NswagMultipleDocuments;

using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;

public class ControllerTypeFilteringOperationProcessor(
    Func<Type, bool> controllerTypeFilter
) : IOperationProcessor
{
    public bool Process(OperationProcessorContext context)
        => context.ControllerType != null && controllerTypeFilter(context.ControllerType);
}
