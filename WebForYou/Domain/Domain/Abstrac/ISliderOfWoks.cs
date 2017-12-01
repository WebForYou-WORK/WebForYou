using System.Collections.Generic;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface ISliderOfWoks
    {
        IEnumerable<SliderOfWork> SliderOfWorks { get; }
        void SaveSlide(SliderOfWork sliderOfWork);
        void RemoveSlide(int slideId);
    }
}
