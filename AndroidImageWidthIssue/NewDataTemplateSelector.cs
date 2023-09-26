using System;
namespace AndroidImageWidthIssue
{
    public class NewDataTemplateSelector : DataTemplateSelector
	{
        public DataTemplate ImageDataTemplate { get; set; }
		public NewDataTemplateSelector()
		{
		}

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ImageDataTemplate;
        }
    }
}

