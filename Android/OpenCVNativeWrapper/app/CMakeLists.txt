# For more information about using CMake with Android Studio, read the
# documentation: https://d.android.com/studio/projects/add-native-code.html

# Sets the minimum version of CMake required to build the native library.

cmake_minimum_required(VERSION 3.4.1)

find_library( # Sets the name of the path variable.
              log-lib

              # Specifies the name of the NDK library that
              # you want CMake to locate.
              log )

# This is defining the native library we want to build
add_library( native-lib SHARED src/main/cpp/native-lib.cpp )

add_library( opencv-lib SHARED IMPORTED )
set_target_properties( opencv-lib PROPERTIES IMPORTED_LOCATION
             ${CMAKE_SOURCE_DIR}/src/main/libs/${ANDROID_ABI}/libopencv_java3.so )

include_directories(src/main/cpp/include)

target_link_libraries( native-lib
                       opencv-lib
                       ${log-lib} )