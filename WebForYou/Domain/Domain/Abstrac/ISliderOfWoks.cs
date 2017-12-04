using System.Collections.Generic;
using System.IO;
using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface ISliderOfWoks
    {
        IEnumerable<SliderOfWork> SliderOfWorks { get; }
        void SaveSlide(SliderOfWork sliderOfWork);
        void RemoveSlide(int slideId, DirectoryInfo directory);
        void SaveSlidePhoto(int sliderId, string url);
        void RemoveSlidePhoto(int sliderId, DirectoryInfo directory);
    }
}
