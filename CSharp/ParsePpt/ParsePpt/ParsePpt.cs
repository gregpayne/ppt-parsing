﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using A = DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;
using B = DocumentFormat.OpenXml.OpenXmlElement;
using System.Reflection;
using System.Diagnostics;

namespace ParsePpt
{
    public class ParsePpt
    {
        public static long getSlideCount(string path)
        {
            using (PresentationDocument ppt = PresentationDocument.Open(path, false))
            {
                // Get RelationshipId for first slide
                PresentationPart part = ppt.PresentationPart;
                OpenXmlElementList slideIds = part.Presentation.SlideIdList.ChildElements;
                return (int)slideIds.Count<B>();
            }
        }

        public static string getSlideText(string path, int s)
        {
            try
            {
                using (PresentationDocument ppt = PresentationDocument.Open(path, false))
                {
                    // Get RelationshipId for first slide
                    PresentationPart part = ppt.PresentationPart;
                    OpenXmlElementList slideIds = part.Presentation.SlideIdList.ChildElements;
                    string relId = (slideIds[s] as SlideId).RelationshipId;

                    // Get the slide part from the RelationshipId
                    SlidePart slide = (SlidePart)part.GetPartById(relId);

                    // Build StringBuilder object
                    StringBuilder sb = new StringBuilder();

                    // Get the inner text of the slide
                    IEnumerable<A.Text> texts = slide.Slide.Descendants<A.Text>();
                    foreach (A.Text text in texts)
                    {
                        sb.Append(text.Text + "\n");
                    }
                    return sb.ToString();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return ("Slide " + s + " does not exist in the presentation");
            }
        }

        public static string getImagePath(string path, int s)
        {
            try
            {
                using (PresentationDocument ppt = PresentationDocument.Open(path, false))
                {
                    // Get RelationshipId for first slide
                    PresentationPart part = ppt.PresentationPart;
                    OpenXmlElementList slideIds = part.Presentation.SlideIdList.ChildElements;
                    string relId = (slideIds[s] as SlideId).RelationshipId;

                    // Get the slide part from the RelationshipId
                    SlidePart slide = (SlidePart)part.GetPartById(relId);

                    // Build StringBuilder object
                    StringBuilder sb = new StringBuilder();

                    // Get the inner text of the slide
                    List<ImagePart> imageParts = new List<ImagePart>(slide.ImageParts);
                    //IEnumerable<ImagePart> images = slide.ImageParts();
                    foreach (ImagePart image in imageParts)
                    {
                        sb.Append(image.Uri + "\n");
                    }
                    return sb.ToString();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return ("Slide " + s + " does not exist in the presentation");
            }
        }

        public static string getAssemblyVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
    }
}
