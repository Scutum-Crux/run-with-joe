using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;


public class reklam : MonoBehaviour
{

    private BannerView bannerView;

    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            // This callback is called once the MobileAds SDK is initialized.
        });

        this.RequestBanner();
    }


    void RequestBanner()
    {
        string reklamID = "ca-app-pub-9395415633428331/7327895872";

    


        this.bannerView = new BannerView(reklamID, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }




}
