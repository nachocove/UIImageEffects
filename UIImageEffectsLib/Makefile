
XBUILD=xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/UIImageEffectsLib.xcodeproj
TARGET=UIImageEffectsLib

all: build libUIImageEffectsLibSDK.a

build:
	mkdir -p build

libUIImageEffectsLib-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libUIImageEffectsLib-x86_64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch x86_64 -configuration Release clean build TARGET_BUILD_DIR='./build/build-x86_64'
	-mv -f ./build/build-x86_64/lib$(TARGET).a $@

libUIImageEffectsLib-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libUIImageEffectsLib-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build TARGET_BUILD_DIR='./build/build-arm64'
	-mv -f ./build/build-arm64/lib$(TARGET).a $@

libUIImageEffectsLibSDK.a: libUIImageEffectsLib-i386.a libUIImageEffectsLib-armv7.a libUIImageEffectsLib-arm64.a
	lipo -create -output $@ $^

clean:
	-rm -fr build
	-rm -f *.a *.dll

