mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },
  ShowAdsAlert:function(){
    window.alert("ShowAds");
  },

  ShowAds: function(){
    console.log("-------show  ads--------");
    YaGames.init().then(ysdk => ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          // some action after close
            console.log("------- close ads--------");

        },
        onError: function(error) {
          // some action on error
        }
        }
        }))
    
  },

});