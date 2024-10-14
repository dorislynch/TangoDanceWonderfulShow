
# react-native-tango-dance-wonderful-show

## Getting started

`$ npm install react-native-tango-dance-wonderful-show --save`

### Mostly automatic installation

`$ react-native link react-native-tango-dance-wonderful-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-tango-dance-wonderful-show` and add `RNTangoDanceWonderfulShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNTangoDanceWonderfulShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNTangoDanceWonderfulShowPackage;` to the imports at the top of the file
  - Add `new RNTangoDanceWonderfulShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-tango-dance-wonderful-show'
  	project(':react-native-tango-dance-wonderful-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-tango-dance-wonderful-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-tango-dance-wonderful-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNTangoDanceWonderfulShow.sln` in `node_modules/react-native-tango-dance-wonderful-show/windows/RNTangoDanceWonderfulShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Tango.Dance.Wonderful.Show.RNTangoDanceWonderfulShow;` to the usings at the top of the file
  - Add `new RNTangoDanceWonderfulShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNTangoDanceWonderfulShow from 'react-native-tango-dance-wonderful-show';

// TODO: What to do with the module?
RNTangoDanceWonderfulShow;
```
  