[![] (http://www.compass.ie/wordpress/wp-content/uploads/Compass-logo-Final-300x104.png)](http://www.compass.ie)

# ArcGIS for Android Xamarin Bindings

====================

Xamarin binding project for ArcGIS for Android and a demo application using the bindings.

These bindings are based on ArcGIS for Android version 10.2.4 (October 2014) 

## Usage example

```
var map = FindViewById<MapView> (Resource.Id.mapView);
var bingMapLayer = new BingMapsLayer ("ENTER_YOUR_API_KEY",BingMapsLayer.MapStyle.Aerial);
map.AddLayer (bingMapLayer);
```

## Known bugs and limitations
- Not all the features on the SDK might be available
- Not fully tested

## Credits
* [user Shawn Castrianni](http://code.google.com/p/nettopologysuite) on the Xamarin Forums

## License
Copyright 2014, [Compass Informatics Ltd](http://www.compass.ie/).

Licensed under the [MIT License](http://opensource.org/licenses/MIT) or see the [`LICENSE`](https://github.com/compassinformatics/tessera/blob/master/LICENSE) file.

## Author
- Michele Scandura - 
[gitHub](https://github.com/mikescandy) or  [Twitter](https://twitter.com/mikescandy)
- Compass Informatics - [gitHub](https://github.com/compassinformatics), [Twitter](https://twitter.com/CompassInfo) or [web](https://github.com/mikescandy) 


## Logo
Copyright 2014, [Compass Informatics Ltd](http://www.compass.ie/).
