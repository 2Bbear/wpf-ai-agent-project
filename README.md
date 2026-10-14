# 간단한 MVVM WPF 카운터

.NET 8과 WPF로 만든 최소한의 MVVM 예제입니다. 화면에는 현재 카운트가 표시되며, **증가**와 **초기화** 버튼을 사용할 수 있습니다. 카운터 상태와 동작은 ViewModel에 있고 화면은 XAML 바인딩으로 이를 표시합니다.

## 사전 요구사항

- Windows
- .NET 8 SDK

WPF 앱은 Windows에서 실행해야 합니다. `EnableWindowsTargeting` 설정으로 Windows가 아닌 환경에서도 Windows 대상 참조 팩을 사용해 빌드할 수 있지만, 이 환경에서 앱을 실행할 수는 없습니다.

## 프로젝트 구조

```text
WpfMvvmApp.sln
src/WpfMvvmApp/
├── App.xaml
├── Common/
│   ├── ObservableObject.cs
│   └── RelayCommand.cs
├── ViewModels/
│   └── MainViewModel.cs
└── Views/
    ├── MainWindow.xaml
    └── MainWindow.xaml.cs
```

## MVVM 역할

- **View** (`Views/MainWindow.xaml`): 카운터 값과 버튼을 표시하고 ViewModel 속성 및 명령에 바인딩합니다.
- **ViewModel** (`ViewModels/MainViewModel.cs`): 카운터 상태, 증가 및 초기화 동작을 관리합니다. 카운트가 0이면 초기화 명령을 비활성화합니다.
- **공통 기능** (`Common`): `ObservableObject`는 속성 변경 알림을 제공하고, `RelayCommand`는 `ICommand`를 구현합니다.

## 실행

저장소 루트에서 다음 명령을 실행합니다.

```bash
dotnet restore WpfMvvmApp.sln
dotnet build WpfMvvmApp.sln
dotnet run --project src/WpfMvvmApp/WpfMvvmApp.csproj
```

Visual Studio에서는 `WpfMvvmApp.sln`을 열고 `WpfMvvmApp`을 시작 프로젝트로 선택한 다음 실행합니다.