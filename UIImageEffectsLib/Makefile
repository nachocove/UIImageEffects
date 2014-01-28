
XBUILD=xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/UIImageEffectsLib.xcodeproj
TARGET=UIImageEffectsLib

all: libUIImageEffectsLibSDK.a

libUIImageEffectsLib-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libUIImageEffectsLib-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libUIImageEffectsLibSDK.a: libUIImageEffectsLib-i386.a libUIImageEffectsLib-armv7.a
	lipo -create -output $@ $^

clean:
	-rm -fr build
	-rm -f *.a *.dll

