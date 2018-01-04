using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain.Abstrac;
using Domain.Entityes;

namespace Domain.Concrete
{
    public class EfSliderOfWoks : ISliderOfWoks
    {
        readonly SliderContext _context = new SliderContext();
        public IEnumerable<SliderOfWork> SliderOfWorks => _context.SliderOfWorks;

        public void SaveSlide(SliderOfWork sliderOfWork)
        {
            if (sliderOfWork.SliderOfWorkId == 0)
            {
                _context.SliderOfWorks.Add(new SliderOfWork
                {
                    PrioritySlide = sliderOfWork.PrioritySlide,
                    SiteAdress = sliderOfWork.SiteAdress,
                    SlideDescription = sliderOfWork.SlideDescription,
                    SlideName = sliderOfWork.SlideName,
                    SlidePicture = sliderOfWork.SlidePicture,
                    SlideDateCreate = DateTime.Now
                });
                _context.SaveChanges();
            }
            else
            {
                SliderOfWork editSlide =
                    _context.SliderOfWorks.FirstOrDefault(x => x.SliderOfWorkId == sliderOfWork.SliderOfWorkId);
                if (editSlide != null)
                {
                    editSlide.PrioritySlide = sliderOfWork.PrioritySlide;
                    editSlide.SiteAdress = sliderOfWork.SiteAdress;
                    editSlide.SlideDescription = sliderOfWork.SlideDescription;
                    editSlide.SlideName = sliderOfWork.SlideName;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
            }
        }

        public void RemoveSlide(int slideId, DirectoryInfo directory)
        {
            SliderOfWork slid = _context.SliderOfWorks.FirstOrDefault(x => x.SliderOfWorkId == slideId);
            if (slid != null)
            {
                string urlPhoto = slid.SlidePicture;
                _context.SliderOfWorks.Remove(slid);
                _context.SaveChanges();
                foreach (FileInfo file in directory.GetFiles()) //Удаление фото из директории
                {
                    if (urlPhoto.Equals(file.ToString()))
                        file.Delete();
                }
            }
            else
                throw new Exception();
        }

        public void SaveSlidePhoto(int sliderId, string url)
        {
            var oneSlide = _context.SliderOfWorks.FirstOrDefault(x => x.SliderOfWorkId == sliderId);
            if (oneSlide != null)
            {
                oneSlide.SlidePicture = url;
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }

        public void RemoveSlidePhoto(int sliderId, DirectoryInfo directory)
        {
            var oneSlide = _context.SliderOfWorks.FirstOrDefault(x => x.SliderOfWorkId == sliderId);
            if (oneSlide != null)
            {
                var urlDell = oneSlide.SlidePicture;
                oneSlide.SlidePicture = "new";
                _context.SaveChanges();
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (file.ToString() == urlDell)
                        file.Delete();
                }
            }
            else
                throw new Exception();
        }
    }
}
