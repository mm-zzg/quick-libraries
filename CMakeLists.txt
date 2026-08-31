cmake_minimum_required(VERSION 3.15)
project(quickmath C)

set(CMAKE_C_STANDARD 11)

add_library(quickmath SHARED
    src/quickmath/quickmath.c
)

target_include_directories(quickmath PUBLIC
    src/quickmath
)

set_target_properties(quickmath PROPERTIES
    C_VISIBILITY_PRESET default
)

install(TARGETS quickmath
    LIBRARY DESTINATION lib
    RUNTIME DESTINATION bin
)
install(FILES src/quickmath/quickmath.h DESTINATION include)
