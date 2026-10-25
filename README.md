# 影像處理桌面應用系統 (C# Image Processing Desktop App)

使用 C# (.NET Windows Forms) 與 **Emgu.CV (OpenCV 的 .NET 封裝)** 開發的圖形化桌面影像處理軟體。支援多圖檔同時開啟與分頁管理，並實作了基礎像素級影像處理與進階電腦視覺演算法。

## 核心功能
- **多分頁與視窗管理 (`TabControl`)：** 支援多張圖片同時載入、分頁切換、自適應縮放（適應視窗、放大、縮小、原始大小）以及動態視窗重排。
- **基礎像素與色彩處理：**
  - 灰階轉換（平均法、亮度法）
  - RGB 彩色濾鏡與補色處理
  - 影像二值化（黑白處理）與自訂文字繪製
- **Emgu.CV 進階電腦視覺處理：**
  - 運用 `Emgu.CV.Mat` 進行高效矩陣運算
  - 8-bit / 24-bit 灰階轉換與色彩通道分離（Red / Green / Blue Channel）
  - 影像反相與 OpenCV 文字標註

## 使用技術
- **開發語言：** C#
- **應用框架：** .NET / Windows Forms
- **電腦視覺庫：** Emgu.CV (OpenCV for .NET)
- **繪圖與效能：** GDI+ (`System.Drawing`), `BitmapData` 記憶體指標操作

## 快速執行與開啟方式
1. 確認電腦已安裝 **Visual Studio**（建議 2019 或 2022 版本）。
2. 下載或 Clone 本專案至機機。
3. 雙擊開啟 **`S12360872.sln`** 方案檔。
4. 在 Visual Studio 中點擊上方綠色 **「啟動 (Start)」** 按鈕，即可編譯並執行桌面應用程式。

## 執行畫面
<img width="800" height="479" alt="image" src="https://github.com/user-attachments/assets/d2a99dcf-aca8-4859-ae6f-68146de3f181" />
<img width="798" height="479" alt="image" src="https://github.com/user-attachments/assets/c0bdf543-6bdf-4132-8901-80f5eb25f9cf" />
