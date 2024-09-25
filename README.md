
# react-native-folk-dance-professional-manage

## Getting started

`$ npm install react-native-folk-dance-professional-manage --save`

### Mostly automatic installation

`$ react-native link react-native-folk-dance-professional-manage`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-folk-dance-professional-manage` and add `RNFolkDanceProfessionalManage.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNFolkDanceProfessionalManage.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNFolkDanceProfessionalManagePackage;` to the imports at the top of the file
  - Add `new RNFolkDanceProfessionalManagePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-folk-dance-professional-manage'
  	project(':react-native-folk-dance-professional-manage').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-folk-dance-professional-manage/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-folk-dance-professional-manage')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNFolkDanceProfessionalManage.sln` in `node_modules/react-native-folk-dance-professional-manage/windows/RNFolkDanceProfessionalManage.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Folk.Dance.Professional.Manage.RNFolkDanceProfessionalManage;` to the usings at the top of the file
  - Add `new RNFolkDanceProfessionalManagePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNFolkDanceProfessionalManage from 'react-native-folk-dance-professional-manage';

// TODO: What to do with the module?
RNFolkDanceProfessionalManage;
```
  