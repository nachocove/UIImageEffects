all:
	make -C UIImageEffectsLib
	make -C UIImageEffectsBinding

clean:
	make -C UIImageEffectsLib clean
	make -C UIImageEffectsBinding clean
