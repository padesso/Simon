$managedDatablockSet = new SimSet() {
   canSaveDynamicFields = "1";
      setType = "Datablocks";

   new t2dImageMapDatablock(Simon0001ImageMap) {
      imageName = "~/data/images/images/Simon0001.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(Simon0003ImageMap) {
      imageName = "~/data/images/images/Simon0003.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(Simon0010ImageMap) {
      imageName = "~/data/images/images/Simon0010.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(Simon0017ImageMap) {
      imageName = "~/data/images/images/Simon0017.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(Simon0024ImageMap) {
      imageName = "~/data/images/images/Simon0024.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(Simon0029ImageMap) {
      imageName = "~/data/images/images/Simon0029.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
   };
   new t2dImageMapDatablock(linkImage) {
      imageName = "~/managed/";
      imageMode = "LINK";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      linkImageMaps = "Simon0001ImageMap Simon0003ImageMap Simon0010ImageMap Simon0017ImageMap Simon0024ImageMap Simon0029ImageMap";
      preload = "1";
      allowUnload = "0";
   };
   new t2dAnimationDatablock(linkImageAnimation) {
      imageMap = "linkImage";
      animationFrames = "5 5 1 5 2 5 3 5 4 5 1 5 4 5 3 5 2 5 1 5 0 5 0 5";
      animationTime = "4.66674";
      animationCycle = "0";
      randomStart = "0";
      startFrame = "0";
   };
};