# AniMa

アニメの視聴管理を楽にするアプリケーションです。


## システム要件
* Windows 10 64ビット版 以上
* .NET 8.0 以上

## インストール方法
Releases からダウンロードした AniMa　(バージョン).zip を展開してください。  

.NET 8.0ランタイムがインストールされていない場合はエラーが表示されてアプリケーションの起動に失敗します。  
その場合には、[.NET 8.0 (Linux、macOS、Windows) をダウンロードする](https://dotnet.microsoft.com/ja-jp/download/dotnet/8.0)
を開き、  
`.NET デスクトップ ランタイム 8.x.x` -> `Windows x64` インストーラーをダウンロードして実行してください。

## ソースコードのビルド方法
git から clone します。
```
git clone https://github.com/crimson-tea/AniMa.git
```

プロジェクトファイルのあるディレクトリに移動し、ビルド・実行します。
```
cd AniMa/AniMa/
dotnet run --configuration Release
```

## 特徴紹介
1. **起動が速い！**
    * メイン画面は通信なしで動作するので瞬く間に起動して操作可能になります。
2. **アニメ登録が楽！**
    * 実際にウェブページを開いて半自動で登録できます。
3. **最新話の視聴ページをすぐ開ける！**
    * 何話を見るか迷うことはありません。

<sub>※アプリケーションの利用方法や環境によって特徴が当てはまらない場合があります。</sub>

## 使い方
### メイン画面
#### アプリ起動後はこの画面が表示されます
初めて起動したときにはリストに何も表示されていません。  
次の項目[探索画面]へ進んで視聴管理するアニメをリストに追加しましょう。  


リストに表示される項目は、`作品のタイトル`、`現在の話数`、`最終更新日`、`次回更新までの時間`、`リリース年`の5つです。  
次回更新までの時間は正確ではないので参考程度に留めておいてください。


##### リストに対する操作紹介
* リストの中の要素をマウス左ダブルクリックするとブラウザで視聴ページが開きます
* `視聴済み`で現在表示されている話を視聴済みにします
* `削除`で完了したアニメ、見ないアニメを非表示にします
* `編集` -> `元に戻す`で誤った操作を取り消せます
* `編集` -> `やり直す`で取り消した操作を復元することができます
* `元に戻す`、`やり直す`は視聴済み、編集、削除に対応しています

これらの動作にはショートカットが設定されています。
|動作|ショートカット1|ショートカット2|
|---|---|---|
|視聴ページを開く|`Control` + `マウス左`クリック|`マウス左`ダブルクリック|
|視聴済み|`Control` + `マウス右`クリック|`マウス右`ダブルクリック|
|削除|`Delete`||
|元に戻す|`Control` + `z`キー||
|やり直す|`Control` + `y`キー||

そのほか、`(アルファベット)`となっているものは`Alt` + `アルファベット`のショートカットが設定されています。  
`最終更新から7日間のみ表示`にチェックを入れることで、今週見ていないアニメのみを表示させることができます。


### 探索画面
#### ウェブサイトのブラウジングでアニメの情報をを半自動で追加できます
* 通常のブラウザにおける新しいタブで開く動作で右のリストにURLが追加されます
   * `Control` + `マウス左`クリック
   * `マウス中ボタン`クリック
   * URLドロップ
* 右のリストボックスのURLを選択すると下のブラウザでページが開きます
* 開いたページの情報を取得できると左のリストにアニメのタイトルが表示されます
* 追加したくないアニメがある場合は、選択して`選択したアニメを削除`を押して削除してください
* `すべてのアニメを追加`ボタンで左のリストに表示されているアニメがすべてメイン画面のリストに追加されます
* アニメの詳細情報が間違っている場合や変更したい場合は次に説明する編集画面で編集してください

同一のURLを2つ以上リストへ追加しないようになっています。  
誤ってURLを消してしまった場合は、必要に応じてアニメを追加した後、探索画面を開きなおしてください。

### 編集画面
#### アニメの詳細情報の編集ができます
* 編集可能な項目一覧
  * 作品名
  * 更新日時
  * 更新日時時点での話数
  * リリース年

### 設定画面
#### 利用するブラウザを選べます
* `開く`でブラウザの実行ファイルを選んでください
* 実行ファイルのパスを直接入力することも可能です
* 上級者向けにブラウザ起動時の引数を設定することもできます
* 設定画面を閉じる際に保存されます

### About画面
#### このアプリや使用ライブラリのライセンスなどを確認できます

### アニメ追加画面（非推奨の機能）
#### 探索画面で正常に追加されなかったアニメの追加を手動で行えます
* メイン画面の`AnimeList:`ラベルをクリックして開けます
* 注釈通りに入力してください

### その他
メイン画面と探索画面以外のウィンドウは`Escape`で閉じることができます。

## 対応サイト
[ABEMA](https://abema.tv/video/genre/animation)
（動作確認はアニメジャンルでのみ行っています）
