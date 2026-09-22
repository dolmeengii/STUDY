# SECTION_01

### node package manager

- npm init -y: node package manager 초기화 (자동 초기화)
- npm install typescript --save-dev : 개발 의존성에 typescript 추가 // 컴파일러 역할
- npm outdated : 패키지 의존성을 확인하여 최신버전을 확인할 수 있는 명령어
  > 실행했는데 아무것도 출력되지 않으면, 검사 대상 중 업데이트할 패키지가 없다는 의미

### 컴파일

- npx tsc : 컴파일러 실행 명령어

### 해당 레슨에서 적용한 컴파일러 설정

```json
{
  "compilerOptions": {
    // 컴파일된 JavaScript 코드가 호환될 ECMAScript의 버전을 지정합니다.
    // 여기서는 최신 ECMAScript 표준 버전으로 컴파일 됩니다.
    "target": "ESNext",

    // 모듈 시스템을 지정합니다. CommonJS 모듈 시스템은 Node.js에서 사용되는 표준입니다.
    // 컴파일된 코드는 CommonJS 모듈 형식을 따릅니다.
    "module": "commonjs",

    // 출력 폴더 구조를 정하는 소스 기준 위치
    "rootDir": "./src",

    // 컴파일된 JavaScript 파일이 출력될 디렉토리를 지정합니다.
    // 여기서는 `./dist` 디렉토리에 컴파일된 파일이 저장됩니다.
    "outDir": "./dist",

    // CommonJS 모듈을 ES6 모듈처럼 사용할 수 있도록 추가적인 코드 변환을 수행합니다.
    // 주로 `import` 구문을 사용할 때 유용합니다.
    "esModuleInterop": true,

    // 파일 이름의 대소문자 일관성을 강제합니다.
    // 파일을 불러올 때 대소문자가 일치하지 않으면 오류를 발생시킵니다.
    // 이는 특히 대소문자를 구분하는 파일 시스템에서 유용합니다.
    "forceConsistentCasingInFileNames": true,

    // 엄격한 타입 검사를 활성화합니다.
    // 여러 가지 타입 검사 옵션을 포함하여 더욱 엄격한 타입 체크를 수행합니다.
    "strict": true,

    // .d.ts 파일의 타입 검사를 건너뜁니다.
    // 이는 컴파일 속도를 높이기 위해 유용합니다.
    "skipLibCheck": true
  },

  // 컴파일 대상 파일을 지정합니다.
  // 여기서는 `src` 디렉토리 아래의 모든 `.ts` 파일을 포함합니다.
  "include": ["src/**/*.ts"],

  // 컴파일에서 제외할 파일을 지정합니다.
  // 여기서는 `node_modules` 디렉토리를 제외합니다.
  "exclude": ["node_modules"]
}
```

#### VSCode 에서 타입스크립트 버전 확인하기

Command Palette > Select TypeScript

> vscode 자체적으로 설치되어있는 타입스크립트 버전으로, 패키지에 설치한 타입스크립트의 버전과는 무관하다.
>
> 오류 메세지는 vscode 의존적이지만 실제 실행은 패키지에 설치한 버전에 의존적이다.

<br/>
<br/>

# SECTION_02
