using System.Collections.Generic;

namespace Antares.DesignPatterns.DataFlow.Pipeline
{
    public abstract class PipelineBase<T> : IPipeline<T>
    {
        /// <summary>
        /// List of processors in the pipeline
        /// </summary>
        protected readonly List<IProcessor<T>> Processors = new List<IProcessor<T>>();

        /// <summary>
        /// To Register filter in the pipeline
        /// </summary>
        /// <param name="filter">A filter object implementing IFilter interface</param>
        /// <returns></returns>
        public PipelineBase<T> Register(IProcessor<T> processor)
        {
            Processors.Add(processor);
            return this;
        }

        /// <summary>
        /// To start processing on the Pipeline
        /// </summary>
        /// <param name="input">
        /// The input object on which processor would execute</param>
        /// <returns></returns>
        public virtual T ProcessAll(T input)
        {
            foreach (var processor in Processors)
            {
                input = processor.Process(input);
            }

            return input;
        }
    }
}
