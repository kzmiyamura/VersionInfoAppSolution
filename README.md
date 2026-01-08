# VersionInfoApp

## 課題内容
- .NET 8 SDK コンソールアプリでプロジェクトのバージョン情報表示
- Git コミットハッシュを自動埋め込み
- テストコードでバージョン情報検証
- GitHub Actions で CI 自動実行

## 追加設定
- GitHub Actions CI でビルド＆テスト自動実行
- Nullable / ImplicitUsings を有効化
- Gitコミットハッシュを Assembly に自動埋め込み
- xUnit でバージョン情報取得をテスト

## 実行方法
```bash
dotnet run --project VersionInfoApp
dotnet test VersionInfoApp.Tests
```

## フォルダ構成
```text
VersionInfoAppSolution/
│
├─ VersionInfoApp/
│ ├─ Program.cs
│ └─ VersionInfoApp.csproj
│
├─ VersionInfoApp.Tests/
│ ├─ VersionTests.cs
│ └─ VersionInfoApp.Tests.csproj
│
├─ .github/workflows/dotnet.yml
├─ .gitignore
├─ README.md
└─ VersionInfoAppSolution.sln

```

---

## ✅ **ポイントまとめ**

- 本体プロジェクトとテストを分離  
- SDKスタイルで Git ハッシュを自動埋め込み  
- xUnit でバージョン情報取得をテスト  
- GitHub Actions で CI 自動実行  
- Private リポジトリ + コラボレーター招待でチーム開発前提  

---

これで **最初から最後までの手順書・ソースコード・CI設定・GitHub設定をすべて含んだ完全版** です。  

