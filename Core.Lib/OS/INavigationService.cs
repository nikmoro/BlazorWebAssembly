using Core.Lib.Enumerations;
using System.Threading.Tasks;

namespace Core.Lib.OS
{
    interface INavigationService
    {
        /// <summary>Navigate to previous view</summary>
        /// <returns></returns>
        Task GoBack();

        /// <summary>Clean a navigation stack to the root</summary>
        /// <returns></returns>
        Task Home();

        /// <summary>Used to remove a modal</summary>
        /// <returns></returns>
        Task PopModal();

        /// <summary>Show a modal</summary>
        /// <param name="pageKey"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task PushModal(PopupsKeys popUpKey);

        Task PushModal(PopupsKeys popUpKey, params object[] parameter);

        /// <summary>Navigate to a page without the page requiring any parameters</summary>
        /// <param name="pageKey"></param>
        /// <returns></returns>
        Task NavigateTo(PagesKeys pageKey);

        /// <summary>Navigate to a page with parameters</summary>
        /// <param name="pageKey"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task NavigateTo(PagesKeys pageKey, params object[] parameter);
        void NavigatePop();
        void NavigateToUrl(string url);
    }
}
